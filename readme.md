DripSharp
=========

C# Wrapper for [Drip Webhooks](https://www.getdrip.com/docs/webhooks)

Usage
---

Create a control action to recieve the webhook from Drip. The use the DripSharp lib to parse the json payload and use it in code:


```csharp
[HttpPost]
public ActionResult DripEvent()
{
	var e = Drip.Parse(Request.InputStream);
	string id = e.Data.Object["id"].Value.ToString();
        string type= e._event;
        string email = e.Data.Object["email"].Value;

	//Store the event details in a db
        _db.sp_DripEventAdd(id, eventType, email);

        return new HttpStatusCodeResult((int)HttpStatusCode.OK);
}
```
