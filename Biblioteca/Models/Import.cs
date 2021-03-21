using System;

namespace Model {
    public static class Import {
        public static void DBImport () {
            new Student ("Kaique Augusto Benedito da Paz", "Kai.Aug.Ben@gmail.com.br", 5);
            new Student ("Joana Liz Assis", "Joana-Liz@hotmail.com.br", 15);
            new Student ("Pietro Hugo da Rocha", "Hugo.da.Rocha@hotmail.com.br", 10);
            new Student ("Kauê José Gabriel Ramos", "kjgRamos@yahoo.com", 20);
            new Student ("Benício Breno da Mota", "Breno-Mota@ig.com.br", 25);

            new Book ("Dom Casmurro", "Machado de Assis", "Livraria Garnier (primeira edição)", Convert.ToDateTime ("14/02/1989"));
            new Book ("Quincas Borba", "Machado de Assis", "Livraria Garnier (segunda edição)", Convert.ToDateTime ("14/02/1891"));
            new Book ("Crepúsculo dos Ídolos", "Friedrich Nietzsche", "Editora Schwarcz S.A.", Convert.ToDateTime ("24/10/1995"));
            new Book ("It - A Coisa", "Stephen King", "Viking Press", Convert.ToDateTime ("15/09/1986"));
            new Book ("A Torre Negra: O Pistoleiro", "Stephen King", "Viking Press", Convert.ToDateTime ("10/06/1982"));
            new Book ("O Senhor dos Anéis: A Sociedade do Anel", "J. R. R. Tolkien", "Allen & Unwin (primeira edição)", Convert.ToDateTime ("29/06/1954"));
            new Book ("O Senhor dos Anéis: As Duas Torres", "J. R. R. Tolkien", "Allen & Unwin (primeira edição)", Convert.ToDateTime ("11/11/1954"));

        }
    }
}