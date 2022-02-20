function create(words) {
   let divElement = document.getElementById('content');
   for (let i = 0; i < words.length; i++) {
      let childDivElement = document.createElement('div');
      let pElement = document.createElement('p');
      pElement.textContent = words[i];
      pElement.style.display = 'none';
      childDivElement.addEventListener('click', () =>{
         pElement.style.display = 'block';
      });
      childDivElement.appendChild(pElement);
      divElement.appendChild(childDivElement);
   }
}