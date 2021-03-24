using System;

namespace Model {
    public static class Import {
        public static void DBImport () {
            new Cliente ("Kaique Augusto Benedito da Paz", Convert.ToDateTime ("14/02/1989"), "940.073.426-36", 5);
            new Cliente ("Joana Liz Assis", Convert.ToDateTime ("24/10/1995"), "011.692.914-65", 15);
            new Cliente ("Pietro Hugo da Rocha", Convert.ToDateTime ("21/04/1988"), "278.544.066-85", 10);
            new Cliente ("Kauê José Gabriel Ramos", Convert.ToDateTime ("02/10/1955"), "602.912.005-08", 20);
            new Cliente ("Benício Breno da Mota", Convert.ToDateTime ("04/12/1982"), "519.336.908-10", 25);

            new VeiculoLeve ("Chevrolet", "Onix", 2019, 150.0, "Preta");
            new VeiculoLeve ("Chevrolet", "Onix Plus", 2019, 200.0, "Preta");
            new VeiculoLeve ("Ford", "Ka", 2019, 120.0, "Vermelho");
            new VeiculoLeve ("Renault", "Kwid", 2019, 150.0, "Branco");
            new VeiculoLeve ("Hyundai", "HB20", 2019, 150.0, "Preta");
            new VeiculoLeve ("Volkswagen", "Gol", 2019, 120.0, "Prata");
            new VeiculoLeve ("Volkswagen", "Polo", 2019, 200.0, "Prata");
            new VeiculoLeve ("Fiat", "Argo", 2019, 200.0, "Vermelho");
            new VeiculoLeve ("Jeep", "Renegade", 2019, 300.0, "Laranja");
            new VeiculoLeve ("Fiat", "Mobi", 2019, 120.0, "Verde");

            new VeiculoPesado ("Volvo", "FH540", 2019, 350.0, "Carteira C");
            new VeiculoPesado ("Volvo", "FH 460", 2019, 300.0, "Carteira D");
            new VeiculoPesado ("DAF", "XF105", 2019, 400.0, "Carteira C");
            new VeiculoPesado ("Scania", "R450", 2019, 250.0, "Carteira C");
            new VeiculoPesado ("Mercedez-Benz", "Actros 2651 ", 2019, 450.0, "Carteira D");
            new VeiculoPesado ("Scania", "R500", 2019, 200.0, "Carteira C");
            new VeiculoPesado ("Mercedez-Benz", "Axor 3344", 2019, 400.0, "Carteira C");
            new VeiculoPesado ("Mercedez-Benz", "Axor 2544", 2019, 450.0, "Carteira D");
            new VeiculoPesado ("Mercedez-Benz", "Actros 2546", 2019, 450.0, "Carteira C");
            new VeiculoPesado ("MAN", "TGX 28.440", 2019, 150.0, "Carteira D");
        }
    }
}