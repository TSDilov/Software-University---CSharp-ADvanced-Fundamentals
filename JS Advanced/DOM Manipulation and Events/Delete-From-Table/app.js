function deleteByEmail() {
    let inputEmailElement = document.querySelector('input[name="email"]');
    let emailsFromTableDataElements = document.querySelectorAll('tr td:nth-of-type(2)');
    let resultElement = document.getElementById('result');
    let emailElements = Array.from(emailsFromTableDataElements);
    let targetElement = emailElements.find(el => el.textContent == inputEmailElement.value);

    if (targetElement) {
        targetElement.parentNode.remove();
        resultElement.textContent = 'Deleted.';
    }else{
        resultElement.textContent = 'Not found.';
    }   
}