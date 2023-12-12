namespace API.Models;
public class Usuario{
    public int UsuarioId { get; set; }
    public String? Nome { get; set; }
    public String? DataNascimento { get; set; }
    public Imc? Imc { get; set; }
    public int ImcId { get; set; }
}