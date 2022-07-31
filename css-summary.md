# CSS Style Summary

```html
<style type="text/css">
  ...
</style>
```

```html
<link rel="stylesheet" type="text/css" herf="path" media="all" />
```

 Default selector
 
| 예시  | 의미 |
|:-----:|:--------------------------------:|
| * { } | 전체요소 |
| p { } |p 태그 |
| .exclass  { } | exclasss라는 class를 사용하는 태그 |
| #exid { } | exid라는 id를 사용하는 태그 |


Advanced Selector
| 예시 | 의미 |
|:-------:|:-------------------------------------------------------------------:|
| section p { } | section 요소의 ```모든``` p 요소 선택 (자식의 자식까지 적용) |
| section > p { } | section 요소의 __바로 아래__ p 요소 선택 |
| h1 + p { } | h1 요소의 __바로 다음 형제 p요소__ 선택 |
| h1 ~ p { } | h1 요소의 __모든 형제 p 요소__ 선택 |
| a[href] | a 요소 중에서 href 속성이 있는 요소 선택 |
| [class ~= button] | class 요소 중에서 button 속성값을 __포함하는__ 요소 선택|
| a[title = us] | a 요소중에서 __"us" 또는 "us-"로 시작하는__ 요소 선택 |
| a[target= blank] | a 요소 중에서 target속성값이 `_blank`인 요소 선택 |
| a[title |= us ] | a 요소 중에서 __"us" 또는 "us-"로 시작하는__ 요소 선택 |
| a[title ^= eng] |  a 요소 중에서 __"eng로 시작하는__ 요소 선택 |
| [href $= xls] | href 속성값이 __xls로 끝나는__ 요소 선택 |
| [href *= w3] | href 속성값이 __w3를 포함하는__ 요소 선택 |
