var http = require("http");
var fs = require("fs");

function onError(err, res) {
    console.error(err);
    res.end('Server Error: ' + err.message);
}

var server = http.createServer(function(req, res) {
    if (req.url == '/') {
        fs.readFile('./titles.json', function(err, data) {
            if (err) {
                onError(err, res);
            }
            else {
                // parse json
                var titles = JSON.parse(data.toString());
                fs.readFile('./template.html', function (err, data) {
                    if (err) {
                        onError(err, res);
                    }
                    else {
                        var tmpl = data.toString();
                        var listContent = titles.join('</li>\r\n<li>');
                        var html = tmpl.replace('%', listContent);
                
                    }
                });
            }
        });
    }
});
server.listen(8000, "127.0.0.1");
