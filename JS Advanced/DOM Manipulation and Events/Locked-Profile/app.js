function lockedProfile() {
    let buttonsElement = document.getElementsByTagName('button');
    for (let button of buttonsElement) {
        button.addEventListener('click', (event) => {
            if (event.target.parentNode.children[2].checked) {
                return;
            }

            if (event.target.textContent === 'Show more') {
                event.target.parentNode.children[9].style.display = 'block';
                event.target.textContent = 'Hide it';
            }else{
                event.target.parentNode.children[9].style.display = 'none';
                event.target.textContent = 'Show more';
            }
        });
    }
}