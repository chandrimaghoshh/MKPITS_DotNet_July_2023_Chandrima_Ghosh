#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct book *ptr);
void main()
{
	struct book b1;
	printf("Enter Title, Author, Book id : ");
	scanf("%s%s%d",b1.title,b1.author,&b1.bookid);
	printbook(&b1);
}
void printbook(struct book *ptr)
{
	printf("Title = %s",ptr->title);
	printf("\nAuthor = %s",ptr->author);
	printf("\nBook id = %d",ptr->bookid);
}
//ALGORITHM
//1.start
//2.define function struct book
//3.declare title,author,bookid
//4.go to main function 
//5.call function printbook(struct book *ptr)
//6.Accept title,author,book,id
//7.call function printbook(struct book &ptr)
//8.print title,author,bookid
//9.stop
