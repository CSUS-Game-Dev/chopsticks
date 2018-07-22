
module.exports = function(router){

    router.get('/check', function(req, res){
        res.send("You checked the number of active games!");
    });

    router.post('/check', function(req, res){
        res.send("You checked the number of active games!");
    });

    return router;
}