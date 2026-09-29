namespace newStart;

public class Complex
{
    public decimal MainNumber {get; set;}
    public decimal Immaginary {get; set;}

    public static Complex operator +(Complex a, Complex b){
        return new Complex{ MainNumber = a.MainNumber + b.MainNumber, Immaginary = a.Immaginary + b.Immaginary};
    }
    public static Complex operator -(Complex a, Complex b){
        return new Complex{ MainNumber = a.MainNumber - b.MainNumber, Immaginary = a.Immaginary - b.Immaginary};
    }
    public static Complex operator /(Complex a, Complex b){
        return new Complex{ MainNumber = a.MainNumber / b.MainNumber, Immaginary = a.Immaginary / b.Immaginary};
    }
    public static Complex operator *(Complex a, Complex b){
        return new Complex{ MainNumber = a.MainNumber * b.MainNumber, Immaginary = a.Immaginary * b.Immaginary};
    }
    public static bool operator ==(Complex a, Complex b){
        return (a.MainNumber == b.MainNumber && a.Immaginary == b.Immaginary);
    }
    public static bool operator !=(Complex a, Complex b){
        return (a.MainNumber != b.MainNumber || a.Immaginary != b.Immaginary);
    }
    public override string ToString()
    {
        return $"{MainNumber} + {Immaginary}i";
    }
}
