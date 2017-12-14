var http = require("http");
var fs = require("fs");

http.createServer(function(req, res) {
    if (req.url == '/') {
        fs.readFile('./titles.json', function(err, data) {
            if (err) {
                console.error(err);
                res.end('Server Error.');
            }
        })
    }
});