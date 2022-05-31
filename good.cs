interface IAdapter
{
    bool Request(string link);
}

class AjaxAdapter : IAdapter
{
    public bool Request(string link)
    {
        // istek ve iade sözü
    }
}

class NodeAdapter : IAdapter
{
    public bool Request(string link)
    {
        // istek ve iade sözü
    }
}

class HttpRequester
{
    private readonly IAdapter Adaptor;

    public HttpRequester(IAdapter adaptor)
    {
        Adaptor = adaptor;
    }

    public bool Fetch(string link)
    {
        return Adaptor.Request(link);
    }
}
