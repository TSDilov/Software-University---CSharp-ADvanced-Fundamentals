function printDeckOfCards(cards) {
    
    let cardArray = [];
    try {
        cards.forEach(card => {
            const face = card.slice(0, card.length - 1);
            const suit = card.slice(card.length - 1);
            cardArray.push(plaingCards(face, suit).toString());
        });

        console.log(cardArray.join(' '));
    } catch (error) {
        console.log(error.message);
    }
    
    function plaingCards(face, suit) {

        const faces = 
                    ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        const suits = {
            'S': '\u2660',
            'H': '\u2665',
            'D': '\u2666',
            'C': '\u2663'
        };
    
        if (!faces.includes(face) || !Object.keys(suits).includes(suit)) {
            
            throw new Error(`Invalid card: ${face}${suit}`);
    
        }
    
        let card = {
            face,
            suit: suits[suit],
            toString: function() {
    
                return `${this.face}${this.suit}`;
    
            }
        };
        
        return card;
    }
}

printDeckOfCards(['AS', '10D', 'KH', '2C']);
printDeckOfCards(['5S', '3D', 'QD', '1C']);