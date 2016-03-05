# FileManagerMvcDemo

在 .net MVC專案中套用GitHub專案 [Filemanager](https://github.com/simogeo/Filemanager)。

整合於在CKEditor，取代CKFinder。

## Filemanager 資料夾說明
[<img src="https://raw.githubusercontent.com/kkman021/FileManagerMvcDemo/master/folder.png">](資料夾結構)
*   connectors  官方提供多種程式語言實做的程式碼，此專案使用底下的mvc資料夾
    *   FilemanagerAreaRegistration.cs  
     註冊MVC路由用，範例改成："FileManager/connectors/mvc/filemanager"
    *   FilemanagerController.cs  
    檔案相關程式碼控制（讀資料夾、上傳檔案、等等...）
*   languages   官方提供的語系檔
*   scripts/filemanager.config.js.default
    >官方提供的設定檔，需自行複製一份存放在同一目錄底下。檔名需為：filemanager.config.js
*   config參數說明
    * culture ：語系設定台灣("culture": "zh-tw")
    * lang：Server端的程式語言。.net mvc ("lang": "mvc")
    * quickSelect：是否可以快速選取（預設:false），目前測試若有資料夾開啟時資料夾無法進入下一層
    * dateFormat：檔案資訊時間顯示格式採用PHP格式。（"dateFormat": "Y m d H:i"）
    * fileRoot：上傳檔案的根目錄路徑。需與Server端的一致，否則會掛。範例使用"fileRoot": "/Upload/"
    * capabilities：圖檔允許的操作行為["select", "download", "rename", "delete", "replace"] 對應 ["選取", "下載", "更名", "刪除", "重新上傳"]
    * fileConnector：自訂的程式路由。官網預設的mvc方式會無法Work，[解法](https://github.com/simogeo/Filemanager)。範例使用："/Filemanager/connectors/mvc/filemanager"
    * upload ：底下有幾個設定
        *  multiple：是否允許一次上傳多個檔案
        *  number：一次上傳多個檔案的個數
        *  imagesOnly：是否只允許上傳圖檔（需注意，Server端上傳時未實做）
        *  fileSizeLimit：上傳圖檔的限制大小（需注意，Server端上傳時未實做）

* FilemanagerController.cs 需設定兩個Web.Config中的AppSetting
    * Filemanager_RootPath 需與fileRoot相同
    * Filemanager_IconDirectory icon的檔案路徑

* Global.asax 需檢查是否有註冊Area
    ```sh
    AreaRegistration.RegisterAllAreas();
    ```
[<img src="https://raw.githubusercontent.com/kkman021/FileManagerMvcDemo/master/view1.png">](實際畫面1)
[<img src="https://raw.githubusercontent.com/kkman021/FileManagerMvcDemo/master/view2.png">](實際畫面2)
[<img src="https://raw.githubusercontent.com/kkman021/FileManagerMvcDemo/master/view3.png">](實際畫面3)

