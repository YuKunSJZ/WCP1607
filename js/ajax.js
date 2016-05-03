var XMLHttpReq;
//创建XMLHttpRequest对象     
function createXMLHttpRequest() {
    if (window.XMLHttpRequest) { //Mozilla 浏览器
        XMLHttpReq = new XMLHttpRequest();
    }
    else if (window.ActiveXObject) { // IE浏览器
        try {
            XMLHttpReq = new ActiveXObject("Msxml2.XMLHTTP");
        } catch (e) {
            try {
                XMLHttpReq = new ActiveXObject("Microsoft.XMLHTTP");
            } catch (e) { }
        }
    }
}

/*处理房屋信息返回的函数*/
function processHourseResponse() {
    if (XMLHttpReq.readyState == 4) { // 判断对象状态
        if (XMLHttpReq.status == 200) { // 信息已经成功返回，开始处理信息
            DisplayHourseInfo();
            //setTimeout("sendRequest()", 1000);
        } else { //页面不正常
            alert(XMLHttpReq.status);
            window.alert("您所请求的页面有异常。");
        }
    }
}



/*显示修改后的房屋信息*/
function DisplayHourseInfo() {

    /*第一种方式:使用XML方式读取数据
    var zujin = XMLHttpReq.responseXML.getElementsByTagName("zujin")[0].firstChild.nodeValue;
    var huxing = XMLHttpReq.responseXML.getElementsByTagName("huxing")[0].firstChild.nodeValue;
    var mianji = XMLHttpReq.responseXML.getElementsByTagName("mianji")[0].firstChild.nodeValue;
    var zhuangxiu = XMLHttpReq.responseXML.getElementsByTagName("zhuangxiu")[0].firstChild.nodeValue;
    var leixing = XMLHttpReq.responseXML.getElementsByTagName("leixing")[0].firstChild.nodeValue;
    var louceng = XMLHttpReq.responseXML.getElementsByTagName("louceng")[0].firstChild.nodeValue;
    var quyu = XMLHttpReq.responseXML.getElementsByTagName("quyu")[0].firstChild.nodeValue;
    var xiaoyu = XMLHttpReq.responseXML.getElementsByTagName("xiaoyu")[0].firstChild.nodeValue;
    */

    /*第2种方式:使用JSON数据格式*/ 
    var hourse = eval('(' + XMLHttpReq.responseText + ')');
    var zujin = hourse["zujin"];
    var huxing = hourse["huxing"];
    var mianji = hourse["mianji"];
    var zhuangxiu = hourse["zhuangxiu"];
    var leixing = hourse["leixing"];
    var louceng = hourse["louceng"];
    var quyu = hourse["quyu"];
    var xiaoqu = hourse["xiaoqu"];

    document.getElementById("zujin_" + current_index).innerHTML = zujin + "元";
    document.getElementById("huxing_" + current_index).innerHTML = huxing;
    document.getElementById("mianji_" + current_index).innerHTML = mianji + "M<sup>2</sup>";
    document.getElementById("zhuangxiu_" + current_index).innerHTML = zhuangxiu;
    document.getElementById("leixing_" + current_index).innerHTML = leixing;
    document.getElementById("louceng_" + current_index).innerHTML = louceng;
    document.getElementById("quyu_" + current_index).innerHTML = quyu;
    document.getElementById("xiaoqu_" + current_index).innerHTML = xiaoqu;
}


/*通过ajax获取房屋信息*/
function Ajax_GetHourse() { 
    createXMLHttpRequest();
    /*为了避免浏览器读取缓存数据，加一个时间戳*/
    var timestamp = (new Date()).getTime();
    var url = "GetHourse.aspx?hourseId=" + encodeURI(current_index) + "&timestamp=" + timestamp;
    XMLHttpReq.open("GET", url, true);
    XMLHttpReq.onreadystatechange = processHourseResponse; //指定响应函数
    XMLHttpReq.send(null);  // 发送请求 
}
