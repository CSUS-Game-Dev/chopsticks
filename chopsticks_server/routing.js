
var gameRouter = require('./game.js');



function ROUTER(router) {
    var self = this;
    self.buildBasicRoutes(router);
    self.buildImportedRoutes(router);
}

ROUTER.prototype.buildBasicRoutes = function(router) {
  var self = this;
    router.get('/', (req, res) => {
        res.send("I'm alive!");
    });

    router.get('/test', (req, res) => {
        console.log("API message received");
        res.send("Are you testing me?");
    });
    
}

ROUTER.prototype.buildImportedRoutes = function(router) {
    var self = this;
    router.use('/game', gameRouter(router));
}

module.exports = ROUTER;