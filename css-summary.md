### CSS Selector
```html
<html>
<head>
   <title>스타일 테스트 페이지</title>
</head>
<body>
    <div class="article">
        <a href="http://www.naver.com" target="_blank">네이버로 이동</a>
    </div>
    <a href="https://www.walterz.net/" target="_blank">내 블로그로 이동</a>
</body>
</html>
```

### 클래스가 지정된 HTML 태그를 선택하는 CSS 선택자
> . 을 사용하여 클래스가 지정된 HTML 태그를 선택
> CSS에서 선택자는 공백을 사용하여 그 단계를 구분
```html
.article { background-color: #ccc; }
.article a { text-decoration: none; }
.article .commentBox { border: 1px solid #aaa; padding: 10px; }
```

### ID를 선택할 때 사용되는 CSS 선택자
> #을 이용하여 id가 부여된 객체를 선택
> id는 HTML 소스코드 내에 단 한 개만 존재
```html
#container { padding: 10px; }
#container .article { background-color: #ccc; }
#container .article a { text-decoration: none; }
#footer { background-color: #000; }
```

### color: {색상}
```html
body { color: #555555; }
```
```html
a { color: #961f1f; }
a:hover { color: #7e4ee9; }
```
```html
/* 굵게 (700) */
.bold { font-weight: bold; }
 
/* 기본 (400) */
.normal { font-weight: normal; }
 
/* 가장 굵게 (900) */
.bolder { font-weight: bolder; }
```

```html
<body>
    <span class="bold">굵게 표시되는 텍스트입니다.</span>
    <div class="normal">
        기본 굵기로 표시되는 텍스트입니다.<br />
        <span class="bolder">가장 굵게 표시되는 텍스트입니다.</span>
    </div>
</body>
```

### border: {font-width}{font-style}{font-color}
>border-style 속성
- solid
- dashed
- dotted
- double
- groove : 그림자가 적용된 선( 움푹 파인 그림자)
- insert: 안쪽으로 들어간 느낌의 그림자가 적용된 선
- outset: 바깥으로 나온 느낌의 그림자가 적용된 선
- ridge: 튀어나온 느낌의 선, 2px 이상의 굵기부터 표현됨
