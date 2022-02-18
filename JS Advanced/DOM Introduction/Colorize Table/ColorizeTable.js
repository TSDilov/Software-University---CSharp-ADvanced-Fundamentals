function colorize() {
    let tableElements = document.getElementsByTagName('tr');
    for (let i = 0; i < tableElements.length; i++) {
        if (i % 2 == 1) {
            tableElements[i].style.backgroundColor = 'teal';
        }
    }
}