using API.Controllers;
namespace API.Models;
public class Imc{

    
public int ImcId { get; set; }
public float Altura { get; set;}
public float Peso { get; set; }
public float Imcc {get; set;} 
public String? Classificacao { get; set; }
public String? Obesidade { get; set; }

public float CalcularImc(){
    Imcc = Peso / Altura * 2;
return Imcc;
}
}
