function numerarTebela(propriedadeName, nomeTag){
    let i = 1;
    let array = document.getElementsByTagName(nomeTag);
    array = collectionToArray(array);
    
    array.forEach(t => {
        if(t.getAttribute("name") === propriedadeName){
            t.innerHTML = i.toString();
            i++;
        }
    });
}

function collectionToArray(colletion){
     array = [];
     for(let i = 0; i < colletion.length; i++){
        array.push(colletion.item(i));
     }
     return array;
}

function filtrarContato(idInput, array){
    input = document.getElementById(idInput).value;
    array = array.map(e =>  JSON.parse(e));
    array = array.filter(e =>  e.Nome.includes(input));
    renderizarTabelaContatosFiltrados(array);
}

criarTag = {
    tag: null,
    ultimaTag: null,
    self: null,
    self: () => {
        self = criarTag;
        self.refer(self);
        return self;
    },
    refer: (self) => this.self = self,
    newBuild: (tag) => {
        self.tag = tag;
        self.ultimaTag = tag;
        return self;
    },
    appendTag: (tag) => {
        self.tag.appendChild(tag);
        self.ultimaTag = tag;
        return self;
    },
    criar: (tag) => {
        self.tag = document.createElement(tag);
        self.ultimaTag = self.tag;
        return self;
    },
    append: (tag) => {
        self.ultimaTag = document.createElement(tag);
        self.tag.appendChild(self.ultimaTag);
        return self;
    },
    proper: (prop, value) => {
        self.ultimaTag.setAttribute(prop, value);
        return self;
    },
    inner: (inner) => {
        self.ultimaTag.innerHTML = inner;
        return self;
    },
    build: () => self.tag
}

atributo = {
    criarTag: null,
    selfA: null,
    build: (criarTag, selfA) => {
        selfA.criarTag = criarTag;
        selfA.selfA = selfA;
        return selfA;
    },
    proper: (prop, value) => {
        selfA.criarTag.ultimaTag.setAttribute(prop, value);
        return selfA;
    },
    next: () => {
        return selfA.criarTag;
    }
}

function renderizarTabelaContatosFiltrados(array){

}