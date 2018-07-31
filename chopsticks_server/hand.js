
class Hand {
    constructor(player, position){
        this.owner = player;
        this.position = position;
        this.fingers = 1;
        this.active = true;

    }

    add_fingers(number){
        if(this.active == true){
            this.fingers = (this.fingers + number) % 5;
            if(this.fingers = 0){
                this.active = false;
            }
        }

        return this.fingers;
    }

    split_fingers(hand){
        if(hand.active == false && this.fingers % 2 == 0 ){
            this.fingers = this.fingers / 2;
            hand.active = true;
            hand.fingers = this.fingers;

            return 0;
        }
        else{
            //nothing
            return 1;
        }
    }
}

module.exports = Hand;