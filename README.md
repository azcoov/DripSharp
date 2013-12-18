DripSharp
=========

C# Wrapper for Drip Webhooks


Usage
---

Create a controller action to recieve the Drip webhook and use DripSharp to parse the JSON payload:

```csharp
[HttpPost]
public ActionResult DripEvent()
{
	var e = Drip.Parse(Request.InputStream);
	string id = e.Data.Object["id"].Value.ToString();
	string type= e._event;
	string email = e.Data.Object["email"].Value;
	
	//Save to the db
	Save(id, type, email);

	return new HttpStatusCodeResult((int)HttpStatusCode.OK);
}
```