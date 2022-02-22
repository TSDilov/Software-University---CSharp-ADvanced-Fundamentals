function encodeAndDecodeMessages() {
    let encodeButtonElement = document.getElementById('main').children[0].children[2];
    let decodeButtonElement = document.getElementById('main').children[1].children[2];
    let message = '';

    encodeButtonElement.addEventListener('click', (event) => {
        message = event.target.parentNode.children[1].value;
        message = message.split('').map(char => {
            let asciCode = char.charCodeAt(0);
            asciCode++;
            return String.fromCharCode(asciCode);
        }).join('');
        event.target.parentNode.children[1].value = '';
        document.getElementsByTagName('textarea')[1].value = message;
    });

    decodeButtonElement.addEventListener('click', (event) => {
        let encodeMessage = event.target.parentNode.children[1].value;
        encodeMessage = encodeMessage.split('').map(char => {
            let asciCode = char.charCodeAt(0);
            asciCode--;
            return String.fromCharCode(asciCode);
        }).join('');
        event.target.parentNode.children[1].value = encodeMessage;
    });
}