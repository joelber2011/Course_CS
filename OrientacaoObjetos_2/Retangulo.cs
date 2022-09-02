using System.Globalization;

class Retangulo{

    public double Largura;
    public double Altura;

    public double AreaRetangulo(){

        return Largura * Altura;
    }

    public double PerimetroRetangulo(){

        return 2 * (Largura + Altura);
    }

    public double DiagonalRetangulo(){

        return Math.Sqrt(Largura * Largura + Altura * Altura);
    }

    // public override string ToString(){

    //     return "ÁREA: " + AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture)
    //     + "PERÍMETRO: " + PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture)
    //     + "DIAGONAL: " + DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture);
    // }


}