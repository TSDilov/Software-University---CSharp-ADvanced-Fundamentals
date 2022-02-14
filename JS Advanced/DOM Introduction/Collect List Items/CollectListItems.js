function extractText() {
    let listedItemsElements = document.getElementById('items');
    let textAreaElement = document.getElementById('result');
    textAreaElement.textContent = listedItemsElements.textContent;
}