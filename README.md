### Stack 구현
--------------
#### 1. 배열을 이용하여 stack 구현하기
> Stack_arr.cs
+ stack 생성
``` C#
    arr = new string[100];
```
###### 배열을 생성하여 이용(배열의 크기는 100으로 한정했다).
+ push
``` C#
public void push(string data){
    arr[top++] = data;
}
```
###### 현재 top에 data를 추가하고, top을 증가시킴.
+ pop
``` C#
public void pop(){
   top--;
   arr[top] = null;
}
```
###### top을 감소시키고, data를 지움.
+ print
``` C#
for(int i=top-1; i>=0; i--){
     Console.Write(arr[i]+" ");
}
```
###### top을 1씩 감소시키며, 배열안의 data를 print.
#### 2. 링크드리스트를 이용하여 stack 구현하기
> Stack_LL.cs
+ Node 구성 
``` C#
public Node(string data){
     this.data = data;
     next = null;
}
```
###### Node는 data와 다음 노드를 가르키는 next로 이루어짐.

+ push
``` C#
public void push(string data){
     Node newnode = new Node(data);
     newnode.next = head;
     head = newnode;
}
```
###### data를 담은 newnode를 생성, 이전 노드가 newnode를 가르키고 newnode에 haed가 이동. 
+ pop
``` C#
public void pop(){
     head = head.next;
}
```
###### head를 이동시켜 마지막 노드와의 연결을 끊음.
+ print
``` C#
for (Node temp = head; temp != null; temp = temp.next){
     Console.Write(temp.data + " ");
}
```
###### head를 시작으로 연결된 노드를 출력.

#### 3. 실행
> Program.cs

1. banana apple kiwi orange 순으로 stack에 push.
2. 2번 pop을 하여 orange kiwi를 밖으로 빼낸다.
3. stack을 print하여 잘 실행되었는지 확인.

![OOP_HW1(1)](https://user-images.githubusercontent.com/122364547/227774698-9ed4f9bd-4641-40b1-a26a-da3169fa26cd.png)
