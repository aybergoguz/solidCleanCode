abstract class AdapterBase
{
    protected string isim;

    public string GetName()
    {
        return isim;
    }
}

class AjaxAdapter : AdapterBase
{
    public AjaxAdapter()
    {
        isim = "ajaxAdaptör";
    }
}

class NodeAdapter : AdapterBase
{
    public NodeAdapter()
    {
        isim = "nodeAdaptör";
    }
}

class HttpRequester : AdapterBase
{
    private readonly AdapterBase Adapter;

    public HttpRequester(AdapterBase adapter)
    {
        Adapter = adapter;
    }

    public bool Fetch(string url)
    {
        var adaptörAdı = Adapter.GetName();

        if (adaptörAdı == "ajaxAdapter")
        {
            return MakeAjaxCall(url);
        }
        else if (adaptörAdı == "httpNodeAdapter")
        {
            return MakeHttpCall(url);
        }
    }

    private bool MakeAjaxCall(string url)
    {
        // istek ve iade sözü
    }

    private bool MakeHttpCall(string url)
    {
        // istek ve iade sözü
    }
}
