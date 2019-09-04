using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AsyadCapital.Base.EntitiesConverterMVCToCore
{


    public partial class Form1 : Form
    {
        bool connectionValid = false;
        private string logsText = "";

        public Form1()
        {
            InitializeComponent();
            cmb_DBProvider.SelectedIndex = 0;
            cmb_DBProvider.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Btn_convert_Click(object sender, EventArgs e)
        {
            string allModifiedStoredProcdures = "";
            string allModelBuilderQuery = "";
            DeleteFolder("AsyadCapital.Entities",true);
            try
            {
                DB_Helper db_helper = new DB_Helper();
                string DBName = "";

                if (db_helper.CheckConnectionStringValidity(txt_ConnectionString.Text,
                        db_helper.GetNamespaceProvider(cmb_DBProvider.Text)) == true)
                {
                    //Get Db Name From Connection String
                    DBName = (db_helper.GetConnectionStringBuilder(txt_ConnectionString.Text)?["database"] ??
                              db_helper.GetConnectionStringBuilder(txt_ConnectionString.Text)?["Initial Catalog"]) as
                        string;
                    if (DBName == null)
                    {
                        MessageBox.Show("Coonection String is not valid", "Alert", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("DB Connection Failed", "Alert", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }




                //MakeMVCScaffolding();
                if (txt_Source.Text == "")
                {
                    MessageBox.Show("Please Enter MVC Context File To Convert", "Alert", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                SyntaxTree tree = CSharpSyntaxTree.ParseText(txt_Source.Text);
                CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

                //Get Context Class
                ClassDeclarationSyntax mvcContextclass = root.DescendantNodes().OfType<ClassDeclarationSyntax>()
                    ?.Where(c => c?.BaseList.Types.FirstOrDefault().Type.ToString() == "DbContext")?.FirstOrDefault();

                if (mvcContextclass == null)
                {
                    MessageBox.Show("Please Add  File contain MVC context class ", "Alert", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //DO Core Scafoollding
                lbl_load.Text = "please wait  untit convert Text File.......";
               

                MakeCoreScaffolding();
                lbl_load.Text = "File  is  Converted";
                //Get Scafoolding Core File

                string Core_ContextFilePath = Path.GetFullPath($@"AsyadCapital.Entities\DBEntities\{DBName}Context.cs");
                StreamReader sr_ScafooldingFile = new StreamReader(Core_ContextFilePath);
                string Core_ContextFile = sr_ScafooldingFile.ReadToEnd();
                SyntaxTree coreTree = CSharpSyntaxTree.ParseText(Core_ContextFile);
                CompilationUnitSyntax coreRoot = coreTree.GetCompilationUnitRoot();


                //Get Core Context Class
                ClassDeclarationSyntax Core_contextclass = coreRoot.DescendantNodes()
                    .OfType<ClassDeclarationSyntax>()
                    ?.Where(c => c?.BaseList.Types.FirstOrDefault().Type.ToString() == "DbContext")?.FirstOrDefault();

                //Get old OnModelCreating method
                var coreOldOnModelCreatingMethod = Core_contextclass?.DescendantNodes()
                    .OfType<MethodDeclarationSyntax>()?.FirstOrDefault(m => m.Identifier.Text == "OnModelCreating");
                if (Core_contextclass == null || coreOldOnModelCreatingMethod == null)
                {
                    MessageBox.Show("Error with Scafooling From DB ", "Alert", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }


                //Get Stored Procdures inside Context Class
                var mvcAllStoredProcedurs = mvcContextclass.DescendantNodes().OfType<MethodDeclarationSyntax>()?.Where(
                    m =>
                        m.Body.ToFullString()
                            .Contains("return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction")).ToList();

                if (mvcAllStoredProcedurs.Count == 0)
                {
                    MessageBox.Show("Any stored Procures not Exists ", null, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // loop on stored Procdures
                foreach (var sp in mvcAllStoredProcedurs)
                {
                    var spAccessModifier = sp.Modifiers.ToFullString();
                    var spMethodName = sp.Identifier;
                    var spMethodParamters = sp.ParameterList;
                    string spDeclationStatmentList = "";
                    string spExecuteParamter = "";
                    var spReturnType = (sp.ReturnType as GenericNameSyntax)?.TypeArgumentList.Arguments[0] ??
                                       sp.ReturnType;

                    var s = spReturnType.ToFullString();

                    if (sp.ReturnType.GetFirstToken().Text == "ObjectResult")
                    {
                        if ((spReturnType).GetType() == typeof(IdentifierNameSyntax))
                        {
                            //add ModelBuilderQuery 
                            allModelBuilderQuery += $"modelBuilder.Query<{spReturnType}>();\n";
                        }

                        string firstsection =
                            $"{spAccessModifier}async Task<List<{spReturnType}>>{spMethodName}{spMethodParamters}"
                            + "\n{"
                            + "\n// Initialization.\n"
                            + $"List<{spReturnType}> {spMethodName}_List = new List<{spReturnType}>();\n"
                            + "try\n"
                            + "{"
                            + "\n// Sql Parameters .  \n";
                        var declationStatmentList =
                            sp.Body.Statements.OfType<LocalDeclarationStatementSyntax>().ToList();
                        foreach (var param in declationStatmentList)
                        {
                            string VariableName = param.Declaration.Variables.First().Identifier.Text;
                            spDeclationStatmentList +=
                                $" {cmb_DBProvider.Text} {VariableName} = new {cmb_DBProvider.Text}("
                                + $"\"@{FirstLetterToupper(VariableName).Substring(0, VariableName.Length - 9)}\""
                                + $", {VariableName.Substring(0, VariableName.Length - 9)} ?? (object)DBNull.Value);\n";
                        }


                        string spExecuteStatment = "";
                        //   if (!Sp_ReturnType.GetType().IsValueType)
                        if ((spReturnType) is IdentifierNameSyntax ||
                            spReturnType.ToFullString().ToLower() == "string")
                        {
                            spExecuteStatment = "// Create Query .  \n"
                                                + $"var query = Query<{spReturnType}>().FromSql(\"EXEC [dbo].[{spMethodName}] ";
                        }
                        else
                        {
                            spExecuteStatment = "// Create Query .  \n"
                                                + $"var query = (IQueryable< {spReturnType} >) Query<Object>().FromSql(\"EXEC[dbo].[{spMethodName}] ";
                        }

                        for (int k = 0; k < declationStatmentList.Count; k++)
                        {
                            spExecuteParamter += $"@{spMethodParamters.Parameters[k].Identifier}={{{k}}}";
                            if ( k  < declationStatmentList.Count-1)
                            {
                                spExecuteParamter += ",";
                            }
                        }

                        spExecuteParamter += $";\"";
                        foreach (var declationStatment in declationStatmentList)
                        {
                            spExecuteParamter +=
                                $",{declationStatment.Declaration.Variables.First().Identifier.Text}";
                        }

                        spExecuteParamter += $");\n{spMethodName}_List =  await query.ToListAsync();\n" +
                                             "}\n catch (Exception ex)\n{\nthrow ex;\n}\n return" +
                                             $" {spMethodName}_List;\n" +
                                             "}\n";
                        allModifiedStoredProcdures +=
                            firstsection + spDeclationStatmentList + spExecuteStatment + spExecuteParamter;

                    }
                    else
                    {
                        string firstsection =
                            $"{spAccessModifier}async Task<{spReturnType}>{spMethodName}{spMethodParamters}"
                            + "\n{"
                            + "\n// Initialization.\n"
                            + $"{spReturnType} result = default({spReturnType}) ;\n"
                            + "try\n"
                            + "{"
                            + "\n// Sql Parameters .  \n";
                        var declationStatmentList =
                            sp.Body.Statements.OfType<LocalDeclarationStatementSyntax>().ToList();
                        foreach (var param in declationStatmentList)
                        {
                            string VariableName = param.Declaration.Variables.First().Identifier.Text;
                            spDeclationStatmentList +=
                                $" {cmb_DBProvider.Text} {VariableName} = new {cmb_DBProvider.Text}("
                                + $"\"@{FirstLetterToupper(VariableName).Substring(0, VariableName.Length - 9)}\""
                                + $", {VariableName.Substring(0, VariableName.Length - 9)} ?? (object)DBNull.Value);\n";
                        }

                        string Sp_ExecuteStatment = "// Create Query .  \n"
                                                    + $"var query = Query<object>().FromSql(\"EXEC [dbo].[{spMethodName}] ";
                        for (int k = 0; k < declationStatmentList.Count; k++)
                        {
                            spExecuteParamter += $"@{spMethodParamters.Parameters[k].Identifier}={{{k}}}";
                            if (k < declationStatmentList.Count - 1)
                            {
                                spExecuteParamter += ",";
                            }

                        }

                        spExecuteParamter += $";\"";
                        for (int k = 0; k < declationStatmentList.Count; k++)
                        {
                            spExecuteParamter +=
                                $",{declationStatmentList[k].Declaration.Variables.First().Identifier.Text}";
                        }

                        spExecuteParamter += $");\nvar queryobject = await query.FirstOrDefaultAsync();\n" +
                                             $"result = ({spReturnType})queryobject;" +
                                             "}\n catch (Exception ex)\n{\nthrow ex;\n}\n return" +
                                             $" result;\n" +
                                             "}\n";
                        allModifiedStoredProcdures +=
                            firstsection + spDeclationStatmentList + Sp_ExecuteStatment + spExecuteParamter;

                    }

                }


                // Add allModelBuilderQueries
                var coreNewOnModelCreatingMethod =
                    coreOldOnModelCreatingMethod.AddBodyStatements(ConvertToSyntaxStatment(allModelBuilderQuery));
                // to delete OldOnModelCreatingMethod from class object
                coreRoot.RemoveNode(coreOldOnModelCreatingMethod, new SyntaxRemoveOptions());
                // to Add NewOnModelCreatingMethod in Class
                var coreContextclassAfterAddingBuilderQueries =
                    Core_contextclass.AddMembers(coreNewOnModelCreatingMethod);
                //Add All Stored Procedures to class Context
                var coreNewContextClass = coreContextclassAfterAddingBuilderQueries.AddMembers(CSharpSyntaxTree
                    .ParseText(allModifiedStoredProcdures).GetCompilationUnitRoot().Members.ToArray());
                //Replace old Context class With new Class Context object
                coreRoot =
                    coreRoot.ReplaceNode(Core_contextclass, coreNewContextClass);
                // Using Statments 
                string selectedProviderNameSpace = db_helper.GetNamespaceProvider(cmb_DBProvider.Text);


                // Add New Using Namespaces
                coreRoot = coreRoot.AddUsings(
                    ConvertToUsingDirectiveArray(new string[]
                    {
                        "System.Collections.Generic", "System.Threading.Tasks", "System.Linq", selectedProviderNameSpace
                    }));


                txt_Target.Text = coreRoot.ToFullString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void DeleteFolder(string Folderpath,bool DeletingSubFiles)
        {
            string path = $@"{Folderpath}";
            // If directory does not exist, don't even try   
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, DeletingSubFiles);
                }
            }
            catch (Exception e)
            {
                
            }
           
        }

        private void MakeCoreScaffolding()
        {

            ExecuteCMDCammand(new string[]
            {
                "mkdir AsyadCapital.Entities",
                "cd AsyadCapital.Entities",
                "dotnet new console",
                "dotnet add package Microsoft.EntityFrameworkCore.SqlServer",
                "dotnet add package Microsoft.EntityFrameworkCore.Design",
                $"dotnet ef dbcontext scaffold  \"{txt_ConnectionString.Text}\" Microsoft.EntityFrameworkCore.SqlServer -o  DBEntities"
            });
        }

        private void ExecuteCMDCammand(params string[] Commands)
        {
            string CommandsText = GetCommandText(Commands);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = CommandsText,
              //  UseShellExecute = false,
               // RedirectStandardOutput = true

            };
            process.StartInfo = startInfo;
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
            //StreamReader reader = process.StandardOutput;
            //logsText = reader.ReadToEnd();
            process.Close();

        }

        private string GetCommandText(string[] commands)
        {
            string CommandsText = "/C ";
            for (int i = 0; i < commands.Length; i++)
            {
                CommandsText += $"{commands[i]} & ";
            }

            return CommandsText;
        }

        private StatementSyntax[] ConvertToSyntaxStatment(string StatmentsText)
        {
            string[] Statments = StatmentsText.Split(';');
            int StatmentsCount = Statments.Length;
            StatementSyntax[] StatementsSyntaxes = new StatementSyntax[StatmentsCount - 1];
            for (int i = 0; i < StatementsSyntaxes.Length; i++)
            {
                StatementsSyntaxes[i] = SyntaxFactory.ParseStatement($"{Statments[i]};");
            }

            return StatementsSyntaxes;
        }

        private UsingDirectiveSyntax[] ConvertToUsingDirectiveArray(string[] NameSpacesName)
        {
            int StatmentsCount = NameSpacesName.Length;
            UsingDirectiveSyntax[] StatementsSyntaxes = new UsingDirectiveSyntax[StatmentsCount];
            for (int i = 0; i < StatmentsCount; i++)
            {
                StatementsSyntaxes[i] = SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(" " + NameSpacesName[i]));
            }

            return StatementsSyntaxes;
        }


        public string FirstLetterToupper(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        private void Btn_copyConverted_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_Target.Text);
        }

        private void Btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(openFileDialog1.FileName);
                StreamReader sr = new StreamReader(path);
                txt_Source.Text = sr.ReadToEnd();
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            if (txt_ConnectionString.Text == "")
            {
                MessageBox.Show("Please Enter Connection string Test", "Alert", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DB_Helper db_helper = new DB_Helper();
            string DBName = "";
            if (db_helper.CheckConnectionStringValidity(txt_ConnectionString.Text,
                    db_helper.GetNamespaceProvider(cmb_DBProvider.Text)) == true)
            {
                connectionValid = true;
                MessageBox.Show("Connection String is Ok", "Alert", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("DB Connection Failed", "Alert", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

        }

        private void btn_SaveConvetedFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(txt_Target.Text);
                }

            }
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
             logsForm logsForm=new  logsForm(logsText);
             logsForm.ShowDialog();

        }
    }
}
