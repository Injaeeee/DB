### ```오프라인 회원제 공산품 마트 데이터베이스 및 응용 프로그램 구현하기 ``` 

### 로그인 후 회원메인 초기화면
![image](./image/회원메인화면.png)  
회원이 로그인을 하고 할 수있는 기능들을 네가지로 나누어 버튼을 만들고 해당 버튼을 클릭할 시 각각의 서비스를 사용할 수 있도록 하였다

### Metro 적용 + 디자인을 적용한 최종 회원메인화면
![image](./image/회원메인화면.png)

### 회원 구입선택 화면
![image](./image/.png)

메인화면에서 상품구매 버튼을 눌렀을 때의 UI이다 
우선 DB 설계와 시작에서 명시해놓았던 요구사항과 기능에 맞춰서 5가지의 매장 중 어느 매장에서 구입을 할지 콤보박스에서 선택하면 해당 매장에서 판매하는 모든 상품들이 상품상세의 데이터그리드뷰에 모두 표시되도록 하였으며 상폼의 카테고리 별로 상품들을 구별해 데이터그리드뷰에 표시되도록 하였다

```예를 들면 "구입할 매장을 선택하세요"밑의 콤보박스를 누르면 5개의 매장이 뜨는데 그 중 한 매장을 선택하면 해당 매장에서 판매하는 모든 상품들이 상품상세 밑 그리드뷰에 모두 표시되며 상품종류 밑 리스트박스에 식품버튼을 누르면 해당 매장의 식품 상품들만 표시된다```


아래코드는 구입선택 폼을 열시 초기 설정 코드이다
```C#
        private void 구입매장선택_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.장바구니상품VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            comboBox1.SelectedIndex = 0; //폼을 열 시 첫번째 매장이 선택되어 있는 상태로 접속
            
            this.장바구니상품VIEWTableAdapter.Fill(this.dataSet11.장바구니상품VIEW);
            this.상품TableAdapter1.Fill(this.dataSet11.상품);
            상품타입listBox.Items.Clear();

            상품타입TableAdapter1.Fill(dataSet11.상품타입);
            mytable = dataSet11.Tables["상품타입"];

            foreach (DataRow mydataRow in mytable.Rows)
            {
                상품타입listBox.Items.Add(mydataRow["상품타입"]);
            } //상품타입 리스트 박스에 매장의 상품타입을 나열
        }
```



