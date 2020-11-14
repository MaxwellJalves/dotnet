class Curso
{
    private int _id { get; set; }
    private string _descricao { get; set; }
    private int _cd_aluno { get; set; }
    private double _valor { get; set; }

    public int id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string descricao
    {
        get { return _descricao; }
        set { _descricao = value; }
    }

    public int cd_aluno
    {
        get { return _cd_aluno; }
        set { _cd_aluno = value; }
    }
    public double valor
    {
        get { return _valor; }
        set { _valor = value; }
    }
}