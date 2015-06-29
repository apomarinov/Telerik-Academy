/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
    */


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
	var domElement = (function () {
		var domElement = {
			init: function(type) {
                this.type = type;
                this._content = '';
                this._children = [];
                this._attributes = [];
                return this;
            },
            appendChild: function(child) {
                if(isDomElement(child)) {
                    child.parent = this;
                }
                
                this._children.push(child);
                return this;
            },
            addAttribute: function(name, value) {
                var attrNameRegex = /^[a-z0-9-]+$/i;
                if(!name || !name.length || !attrNameRegex.test(name)) {
                    throw new Error('Invalid attribute name.');
                }

                var attrIndex = getAttributeIndex(this._attributes, name);
                if(attrIndex == -1) {
                    this._attributes.push({name: name, value: value});
                } else {
                    this._attributes[attrIndex].value = value;
                }

                return this;
            },
            removeAttribute: function(name) {
                var attrIndex = getAttributeIndex(this._attributes, name);
                if(attrIndex == -1) {
                    throw new Error('Attribute "' + name + '" doesn"t exist.');
                }
                this._attributes.splice(attrIndex, 1);

                return this;
            },
            get type(){
                return this._type;
            },
            set type(val){
                var alphaNumericRegex = /^[a-z0-9]+$/i;
                if(!val || !val.length || !alphaNumericRegex.test(val)) {
                    throw new Error('Invalid type.');
                }
                this._type = val;
            },
            get children(){
                return this._children;
            },
            get attributes(){
                return this._attributes.slice().sort(function(textA, textB){
                    return (textA.name < textB.name) ? -1 : (textA.name > textB.name) ? 1 : 0;
                });
            },
            get parent(){
                return this._parent;
            },
            set parent(val){
                if(!isDomElement(val)) {
                    throw new Error('Parent must be domElement');
                }
                this._parent = val;
            },
            get content(){
                return this._content;
            },
            set content(val){
                if(typeof this._children !== 'string' && this._children.length === 1) {
                    // throw new Error('Cant set element with children content.');
                    // this._children[0].content = val;
                    return;
                }

                if(this.content.length > 0) {
                    return;
                }

                this._content = val
            },
            get innerHTML(){
                var startTag = '<' + this.type,
                    endTag = '</' + this.type + '>',
                    elementHTML = startTag;

                for(var i = 0, len = this.attributes.length; i < len; i++){
                    elementHTML += ' ' + this.attributes[i].name + '="' + this.attributes[i].value + '"';
                }

                elementHTML += '>';

                if(this.children.length) {
                    for(var i = 0, len = this.children.length; i < len; i++){
                        if(typeof this.children[i] == 'string') {
                            elementHTML += this.children[i];  
                        } else {
                            elementHTML += this.children[i].innerHTML;
                        }
                    }
                } else {
                    elementHTML += this.content;
                }

                elementHTML += endTag;

                return elementHTML;
            }
        };

        function getAttributeIndex(attributes, attr){
            for(var i = 0, len = attributes.length; i < len; i++){
                if(attributes[i].name == attr) {
                    return i;
                }
            }
            return -1;
        }

        // HOW THE F?
        function isDomElement(obj) {
            return obj.hasOwnProperty('_attributes');
        }

        return domElement;
    } ());

            // var text = 'the text you SEE!',
            //     root = Object.create(domElement).init('p'),
            //     child1 = Object.create(domElement).init('b'),
            //     child2 = Object.create(domElement).init('s');
            // root.appendChild(text);
            // root.appendChild(child1);
            // root.appendChild(text);
            // root.appendChild(child2);
            // root.appendChild(text);
            // console.log(root.innerHTML);
            // console.log('<p>' + text + '<b></b>' + text + '<s></s>' + text + '</p>');

return domElement;
}

module.exports = solve;
