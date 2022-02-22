function focused() {
    let mainDivElement = document.getElementsByTagName('div')[0];
    let divArray = Array.from(mainDivElement.children);

    for (const div of divArray) {
        div.children[1].addEventListener('focus', (e) => {
            e.target.parentNode.classList.add('focused');
        });
        div.addEventListener('blur', (e) => {
            e.target.parentNode.classList.remove('focused');
        })
    }
}