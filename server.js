var connect = require('connect');

connect.createServer(
		connect.static("WebSite")
	).listen(5000);