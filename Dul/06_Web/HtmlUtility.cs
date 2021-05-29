using System;

namespace Dul
{
    public class HtmlUtility
    {
        #region Encode() 함수
        /// <summary>
        /// HTML을 실행하지 않고 소스 그대로 표현해서 바로 웹 페이지에 보여줌
        /// </summary>
        /// <param name="strContent">HTML 태그가 포함된 문자열</param>
        /// <returns>태그가 인코드되어 소스 그대로 표현될 문자열</returns>
        public static string Encode(string strContent)
        {
            string strTemp = "";
            if (String.IsNullOrEmpty(strContent))
            {
                strTemp = "";
            }
            else
            {
                strTemp = strContent;
                strTemp = strTemp.Replace("&", "&amp;");
                strTemp = strTemp.Replace(">", "&gt;");
                strTemp = strTemp.Replace("<", "&lt;");
                //strTemp = strTemp.Replace("\r\n", "<br />");
                strTemp = strTemp.Replace("\n", "<br />"); // \r\n 최근 브라우저 인식 오류
                strTemp = strTemp.Replace("\"", "&#34;");
            }
            return strTemp;
        }
        #endregion

        #region EncodeWithTabAndSpace() 함수
        /// <summary>
        /// HTML을 실행하지 않고 소스 그대로 표현해서 바로 웹 페이지에 보여줌
        /// 추가적으로 탭과 공백도 HTML 코드로 처리해서 출력
        /// 예) 게시판의 이름, 제목 등에서 HTML 사용 금지
        /// </summary>
        /// <param name="strContent">HTML 태그가 포함된 문자열</param>
        /// <returns>태그가 인코드되어 소스 그대로 표현될 문자열</returns>
        public static string EncodeWithTabAndSpace(string strContent)
        {
            return Encode(strContent)
                .Replace("\t", "&nbsp;&nbsp;&nbsp;&nbsp;")
                .Replace(" " + " ", "&nbsp;&nbsp;");
        }
        #endregion
    }
}

//#region 글의 내용(Content) 출력 부분
//string strContent = "";
//switch (Encoding)
//{
//    case "Text/HTML":

//        strContent = Content; //.Replace("<" + "%","&lt%").Replace("%" + ">", "%&gt").Replace("<!--", "&lt!--").Replace("-->", "--&gt");
//        Response.Write(strContent);
//        break;

//    case "Plain-Text":

//        // 검색 필드가 Content이면, 검색 쿼리를 다른 색으로 보여준다.
//        if (Request["SearchField"] == "Content")
//        {
//            strContent = Dul.HtmlUtility.EncodeWithTabAndSpace(Content).Replace(Request["SearchQuery"], "<span style='color:#ff5555;'>" + Request["SearchQuery"] + "</span>");
//            Response.Write(strContent);
//        }
//        else
//        {
//            strContent = Content;
//            Response.Write(Dul.HtmlUtility.EncodeWithTabAndSpace(strContent));
//        }
//        break;

//    case "Mixed-Text":

//        strContent = Content.Replace("<" + "%", "&lt;%").Replace("%" + ">", "%&gt;").Replace("<!--", "&lt!--").Replace("-->", "--&gt").Replace("\n", "<br />").Replace("\t", "&nbsp;&nbsp;&nbsp;&nbsp;").Replace(" " + " ", "&nbsp;&nbsp;");
//        Response.Write(strContent);
//        break;

//    default:

//        // 검색 필드가 Content이면, 검색 쿼리를 다른 색으로 보여준다.
//        if (Request["SearchField"] == "Content")
//        {
//            strContent = Dul.HtmlUtility.EncodeWithTabAndSpace(Content).Replace(Request["SearchQuery"], "<span style='color:#ff5555;'>" + Request["SearchQuery"] + "</span>");
//            Response.Write(strContent);
//        }
//        else
//        {
//            strContent = Content;
//            Response.Write(Dul.HtmlUtility.EncodeWithTabAndSpace(strContent));
//        }

//        break;
//}
