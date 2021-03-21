using System;

namespace Model {
    public static class Import {
        public static void DBImport () {
            new Student ("Kaique Augusto Benedito da Paz", "Email@email.com.br", 5);
            new Student ("Joana Liz Assis", "Email@email.com.br", 15);
            new Student ("Pietro Hugo da Rocha", "Email@email.com.br", 10);
            new Student ("Kauê José Gabriel Ramos", "Email@email.com.br", 20);
            new Student ("Benício Breno da Mota", "Email@email.com.br", 25);

            new Book ("Machado de Assis", "Penguin Companhia", Convert.ToDateTime ("14/02/1989"));
            new Book ("Machado de Assis", "Penguin Companhia", Convert.ToDateTime ("14/02/1989"));
            // new Book  (3, "Friedrich Nietzsche", "Editora Schwarcz S.A.", "24/10/1995");
            // new Book  (4, "Stephen King", "Editora Arqueiro ", "21/04/1988");
            // new Book  (5, "J. R. R. Tolkien", "HarperCollins Brasil", "14/02/1989");
            // new Book  (6, "J. R. R. Tolkien", "HarperCollins Brasil", "21/04/1988");
            // new Book  (7, "J. R. R. Tolkien", "HarperCollins Brasil", "02/10/1955");

        }
    }
}