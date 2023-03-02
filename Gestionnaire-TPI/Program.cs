namespace Gestionnaire_TPI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Attempt login
            Collaborator user = null;
            DialogResult loginRes;
            using (LoginForm login = new LoginForm())
            {
                Application.Run(login);
                user = login.User;
                loginRes = login.DialogResult;
            }

            //in case user closed the login form without actually logging
            if (user == null || loginRes != DialogResult.OK) return;

            //Open main form, everything else should happen inside this form
            Form main = new MainForm(user);
            Application.Run(main);
        }
    }
}