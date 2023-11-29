public class Funcionario
{

    public string id { get; set; } 
    public string name { get; set; }    
    public string datanas { get; set;}
    public string email { get; set;}    
    public string endereco { get; set;}   
    public string estado { get; set;}   
    public string telefone { get; set;}    
    public string funcao { get; set;} 
    public string rg { get; set;}
    public string cpf { get; set;}
    public string cidade { get; set;}      
    public string estsocial { get; set;}    
    public string salario { get; set; }

    public Funcionario(string name, string datanas, string email, string endereco, string estado, string telefone, string funcao, string rg, string cpf, string cidade, string estsocial, string salario)
    {
        this.name = name;
        this.datanas = datanas;
        this.email = email;
        this.endereco = endereco;
        this.estado = estado;
        this.funcao = funcao;
        this.telefone = telefone;
        this.rg = rg;
        this.cpf = cpf;
        this.cidade = cidade;
        this.estsocial = estsocial;
        this.salario = salario; 
    
    }
    public Funcionario() { }




}
