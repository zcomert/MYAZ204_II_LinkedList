using DataStructures.LinkedList.DoublyLinkedList;
using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTest
{
    public class LinkedListTests
    {
        // Bu testin geçmesini saðlayýnýz.
        [Fact]
        public void Traverse_in_DoublyLinkedList()
        {
            // Bu testing geçmesi için
            // Tail -> Head doðru hareket edilmesini saðlayan
            // DoublyLinkedListReverseEnumerator.cs sýnýfýnýn implemente edilmesi beklenmektedir.

            // Arrange & Act
            var linkedList =
                new DoublyLinkedList<int>(new int[] { 10, 20, 30, 40, 50 });

            // Assert
            Assert.Collection(linkedList,
                item => Assert.Equal(50, item),
                item => Assert.Equal(40, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(10, item));
        }

        [Fact]
        public void AddLast_Test()
        {
            // Bu testing geçmesi için DoublyLinkedList.cs sýnýfý içerisindeki
            // AddLast(DbNode<T> newNode) imzalý düðümü implemente etmeniz beklenmektedir.

            // Assert
            var linkedList = new DoublyLinkedList<int>(new List<int> { 10, 20, 30 });

            // Act
            var newNode = new DbNode<int>(23);
            linkedList.AddLast(newNode);

            // Assert
            Assert.Collection(linkedList,
                item => Assert.Equal(23, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(10, item));
        }
    }
}
