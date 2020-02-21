# OpenRastaTester
This is a sample project to show an exception thrown in OpenRasta.

To reproduce, run in IIS Express, and call either `http://localhost:55976/cat` or `http://localhost:55976/dog`, and you'll get a `500` response. 
If you comment out the dog line here https://github.com/hanksjosholo/OpenRastaTester/blob/7f6b0091c09246a2a0e3a2066985302b29278d00/OpenRastaTester/Configuration.cs#L15, the `/cat` endpoint will start working.
