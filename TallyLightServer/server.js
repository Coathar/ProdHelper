const http = require("http");
const { json } = require("stream/consumers");

const host = 'localhost';
const port = 8000;

let camArray = [];

const handleRequest = function(req, res)
{
    switch (req.url)
    {
        case "/ping":
            res.writeHead("200");
            res.end("Pong!");
            break;
        case "/setCams":
            readCam(req, res);
            break;
        case "/getCams":
            sendCam(req, res)
            break;
    }
}

function readCam(req, res)
{
    var body = '';
    req.on('data', function (data) 
    {
        body += data;
    });
    req.on('end', function () 
    {
        console.log(body);
        const incomingObject = JSON.parse(body);

        let prodName = incomingObject["Prod"];
        camArray[prodName] = incomingObject["Cams"];
    });

    res.writeHead(200);
    res.end();
}

function sendCam(req, res)
{
    var body = '';
    req.on('data', function (data) 
    {
        body += data;
    });

    req.on('end', function () 
    {
        console.log(body);
        const incomingObject = JSON.parse(body);

        let prodName = incomingObject["Prod"];
        let camName = incomingObject["Camera"];

        let camList = camArray[prodName];

        let state = 0;

        if (camList === undefined)
        {
            res.writeHead(200);
            res.end(`${state}`);
            return;
        }

        camList.forEach(element => 
        {
            if (element.CameraName === camName)
            {
                state = element.State
            }
        });

        res.writeHead(200);
        res.end(`${state}`);
    });
}

const server = http.createServer(handleRequest);
server.listen(port, host, () => 
{
    console.log(`Server is running on http://${host}:${port}`);
});