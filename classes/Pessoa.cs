class Pessoa
{
    private int matricula;
    private string nome;
    private int idade;
    private string profissao;

    public Pessoa(int m, string n, int idade, string p)
    {
        setMatricula(m);
        setNome(n);
        setIdade(idade);
        setProfissao(p);
    }
    public int getMatricula()
    {
        return this.matricula;
    }
    public void setMatricula(int m)
    {
        this.matricula = m;
    }
    public string getNome()
    {
        return this.nome;
    }
    public void setNome(string n)
    {
        this.nome = n;
    }
    public int getIdade()
    {
        return this.idade;
    }
    public void setIdade(int i)
    {
        if (i != 0)
        {
            this.idade = i;
        }
        else
        {
            this.idade = 0;
        }
    }
    public string getProfissao()
    {
        return this.profissao;
    }
    public void setProfissao(string p)
    {
        if (p.Equals(""))
        {
            throw new System.Exception("Este campo deve ser preenchido obrigatoriamente.");
        }
        else
        {
            this.profissao = p;
        }
    }
}


