var express = require('./node_modules/express');
var bodyParser = require('./node_modules/body-parser');

var app = express();
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

var routing = require('./routing.js');

var game = require('./game.js');

var port_number = 3000;

function SERVER(){
    var self = this;

    var router = express.Router();
    app.use('/api', router);

    var rest_router = new routing(router);

    app.get('/test', (req, res) => {
        console.log("Message received!");
        res.send('Are you testing me?');
    });

    app.listen(port_number, () => console.log("Active on port " + port_number));
}

new SERVER();
