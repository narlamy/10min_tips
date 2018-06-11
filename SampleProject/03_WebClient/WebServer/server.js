var express = require('express');
var bodyParser = require('body-parser');
//var cookieParser = require('cookie-parser');

process.on('uncaughtException', function (err) {
    
    //var logger = require('./Modules/Logger');
    //logger.error('[ServerApp] ' + err.stack);
    console.log(err.stack)
});

var app = express();
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

// 요청 프로토콜 연결
// 미정의 프로토콜 
// app.post('/*', function (request, response) {
    
//     var output = {
//         Message : 'Unknown request type : "' + request.path + '"'
//     }
//     console.warn('[Game] unknown request : ' + request.path);
//     response.status(403);
//     response.json(output);
// });

// app.get('/*', function (request, response) {
    
//     console.warn('[Game] unknown request : ' + request.path);
//     response.status(403);
//     response.response('unknown request');
// });

app.get('/check', require('./check'));
app.post('/test', require('./test'));

// HTTP 서버 구동
var http = require('http');
var port = 1234;
http.createServer(app).listen(port, () => {
    
    console.log(">> Listen...");
})