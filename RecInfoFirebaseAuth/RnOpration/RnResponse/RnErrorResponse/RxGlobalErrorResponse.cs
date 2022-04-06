namespace RecInfoFirebaseAuth.RnOpration.RnResponse.RnErrorResponse;

/*
{
    "error": {
        "code": 400,
        "message": "EMAIL_NOT_FOUND",
        "errors": [
        {
            "message": "EMAIL_NOT_FOUND",
            "domain": "global",
            "reason": "invalid"
        }
        ]
    }
}
*/
public class RxGlobalErrorResponse
{
    public RxGlobalErrorRoot Error { get; set; }
}

public class RxGlobalErrorRoot
{
    public int Code { get; set; }

    public string Message { get; set; }

    public List<RxGlobalErrorSub> Errors { get; set; }
}

public class RxGlobalErrorSub
{
    public string Message { get; set; }
    public string Domain { get; set; }
    public string Reason { get; set; }
}