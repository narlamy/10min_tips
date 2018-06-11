module.exports = function(request, response) {

    // let json = JSON.stringify(request.body);
    // response.respone(json);

    response.respone(request.body);
}