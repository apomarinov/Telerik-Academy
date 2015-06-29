/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function validateBook(book){
			if(book.title.length < 2 || book.title.length > 100) {
				throw new Error('Invalid title.');
			}
			if(book.category.length < 2 || book.category.length > 100) {
				throw new Error('Invalid category.');
			}
			if(!book.author.length) {
				throw new Error('Invalid author.');	
			}
			if(hasBookWithProperty(book, 'title')) {
				throw new Error('Book title exists.');		
			}
			if(book.isbn.length < 10 || book.isbn.length > 13) {
				throw new Error('Invalid ISBN.');		
			}
			if(hasBookWithProperty(book, 'isbn')) {
				throw new Error('Book ISBN exists.');		
			}
		}

		function hasBookWithProperty(book, prop){
			for(var i = 0, len = books.length; i < len; i++){
				if(books[i][prop] === book[prop]) {
					return true;
				}
			}
			return false;
		}

		function listBooks(options) {
			var foundBooks = books;
			if(options && bookHasProperty(Object.keys(options)[0])){
				foundBooks = getBooksByProperty(options);
			}
			return foundBooks.slice().sort(function(a, b){
				return a.ID - b.ID;
			});
		}

		function getBooksByProperty(options) {
			var foundBooks = [],
				propertyName = Object.keys(options)[0];
			for(var i = 0, len = books.length; i < len; i++){
				if(books[i][propertyName] === options[propertyName]) {
					foundBooks.push(books[i]);
				}
			}
			return foundBooks;
		}

		function bookHasProperty(property) {
			if(books.length && books[0].hasOwnProperty(property)) {
				return true;
			}
			return false;
		}

		function addBook(book) {
			validateBook(book);

			if(!hasCategory(book.category)) {
				addCategory(book.category);
			}

			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function listCategories() {
			return categories.slice().sort(function(a, b){
				return a.ID - b.ID;
			});
		}

		function hasCategory(cat) {
			return categories.indexOf(cat) !== -1;
		}

		function addCategory(cat) {
			categories.push(cat);
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
