module.exports = function(request, response) {

    //let json = JSON.stringify(request.body);
    //response.json(request.body);

    console.log(request.body);
    response.send(request.body);
}