var express = require('./node_modules/express');
var bodyParser = require('./node_modules/body-parser');

var app = express();
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

var port_number = 3000;

app.get('/', (req, res) => {
    console.log("Message received!");
    res.send('Hopefully you get this!');
});

app.get('/test', (req, res) => {
    console.log("Message received!");
    res.send('You sent this one to a different URL, huh?');
});

app.post('/', (req, res) => {
    console.log("Message received!");
    console.log("The message body contains: " + req.body.Info);

    res.send('The message you sent contained: ' + req.body.Info);
});

app.listen(port_number, () => console.log('Listening on ' + port_number));