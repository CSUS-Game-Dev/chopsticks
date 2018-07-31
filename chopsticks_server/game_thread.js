
function GAME_THREAD(game_id, players){
    var self = this;
    self.game_id = game_id;
    self.players = players;
    self.setup();
}

GAME_THREAD.prototype.setup = function(){

}

GAME_THREAD.prototype.players = [null, null];

module.exports = GAME_THREAD;