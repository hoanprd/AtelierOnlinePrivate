namespace migrate
{
	internal class ResultString
	{
		public const string NEED_FACEBOOK_ADAPTER = "Facebook adapter required.";

		public const string NEED_GPGS_ADAPTER = "GPGS adapter required.";

		public const string GPGS_GETAUTHCODE_NEED_LOGOUT = "Please try again after calling the GPGS Logout API.";

		public const string NEED_HANGAME_MIX_SDK = "HangameMix SDK required.";

		public const string COMMON_FAILED_FORMAT_WITH_ERROR = "{0} failed. error : {1}";

		public const string CLIENT_NAME_CANVAS = "Canvas";

		public const string CLIENT_NAME_IOS = "iOS";

		public const string CLIENT_NAME_ANDROID = "Android";

		public const string CLIENT_NAME_STANDALONE = "Standalone";

		public const string SERVICEDOMAIN_NAME_KAKAOGAME = "KAKAOGAME";

		public const string SERVICEDOMAIN_NAME_GLOBALGAME_ROYAL = "GLOBALGAME_ROYAL";

		public const string SERVICEDOMAIN_NAME_TOASTGAME = "TOASTGAME";

		public const string ONLY_ANDROID = "Only supports Android.";

		public const string ONLY_IOS = "Only supports iOS.";

		public const string ONLY_ANDROID_AND_IOS = "Only supports Android and iOS.";

		public const string ONLY_WEBGL = "Only supports WebGL.";

		public const string NOT_SUPPORTED_LOGIN_TYPE = "Not supported login type.";

		public const string NOT_SUPPORTED_EDITOR = "Not supported method in the editor. Always return success";

		public const string NOT_SUPPORTED_METHOD_CURRENT_PLATFORM = "Not supported method in current platform.";

		public const string NOT_SUPPORTED_PLATFORM_ALWAYS_SUCCESS = "Not supported method in current platform. Always return success.";

		public const string ALREADY_INITIALIZED = "Already initialized.";

		public const string LOG_INVALID_PARAM = "Invalid parameter.";

		public const string LOG_INIT_SUCCESS = "Initialize success.";

		public const string LOG_INIT_FAILURE = "Failed to initialize.";

		public const string LOG_INIT_ALREADY_CALLED = "Init() has already been called.";

		public const string LOG_AUTH_SUCCESS_PLAYER_PROFILE = "Load player profile success.";

		public const string LOG_AUTH_FAILURE_PLAYER_PROFILE = "Failed to load player profile.";

		public const string LOG_AUTH_ALREADY_LOGIN_CALLED = "Login() has already been called.";

		public const string LOG_AUTH_ALREADY_LOGGED_IN = "Already logged in.";

		public const string LOG_AUTH_PUNISHED_USER = "Player is a punished user";

		public const string LOG_AUTH_INVALID_UUID = "Invalid UUID.";

		public const string LOG_PROFILE_SUCCESS_LOAD_PROFILE = "Load profile success.";

		public const string LOG_PROFILE_FAILURE_LOAD_PROFILE = "Failed to load profile.";

		public const string LOG_PROFILE_SUCCESS_LOAD_DETAIL_PROFILE = "Load detail profile success.";

		public const string LOG_PROFILE_FAILURE_LOAD_DETAIL_PROFILE = "Failed to load detail profile.";

		public const string LOG_PROFILE_SUCCESS_DOWNLOAD_PHOTO = "Download photo success.";

		public const string LOG_PROFILE_FAILURE_DOWNLOAD_PHOTO = "Failed to download photo.";

		public const string LOG_PAYMENT_ALREADY_CALLED = "PurchaseItem() has already been called.";

		public const string LOG_PAYMENT_SUCCESS_PURCHASE_ITEM = "Purchase item success.";

		public const string LOG_PAYMENT_FAILURE_PURCHASE_ITEM = "Failed to purchase item.";

		public const string LOG_PAYMENT_SUCCESS_INITIATE = "Initiate payment success.";

		public const string LOG_PAYMENT_FAILURE_INITIATE = "Failed to initiate payment.";

		public const string LOG_PAYMENT_SUCCESS_PREPARE = "Prepare payment success.";

		public const string LOG_PAYMENT_FAILURE_PREPARE = "Failed to prepare payment.";

		public const string LOG_PAYMENT_SUCCESS_FB_PAY = "Facebook payment success.";

		public const string LOG_PAYMENT_FAILURE_FB_PAY = "Failed to pay with facebook.";

		public const string LOG_PAYMENT_NOT_EXIST_RECEIPT = "Not exist receipt";

		public const string LOG_PAYMENT_SUCCESS_ADD_ITEM = "Add item success.";

		public const string LOG_PAYMENT_FAILURE_ADD_ITEM = "Failed to add item.";

		public const string LOG_PAYMENT_FAILURE_CONFIRM_ORDER = "Failed to confirm order.";

		public const string LOG_PAYMENT_SUCCESS_SEND_LOG = "Send payment log success.";

		public const string LOG_PAYMENT_FAILURE_SEND_LOG = "Failed to send payment log.";

		public const string LOG_PAYMENT_SUCCESS_LOAD_ITEM_INFO = "Load purchasable item info success.";

		public const string LOG_PAYMENT_FAILURE_LOAD_ITEM_INFO = "Failed to load purchasable item info.";

		public const string LOG_DELIVERY_SUCCESS_DELIVERY_ITEM = "Delivery item success.";

		public const string LOG_DELIVERY_FAILURE_DELIVERY_ITEM = "Failed to delivery item.";

		public const string LOG_DELIVERY_SUCCESS_CONFIRM_DELIVERY = "Confirm delivery success.";

		public const string LOG_DELIVERY_FAILURE_CONFIRM_DELIVERY = "Failed to confirm delivery.";

		public const string LOG_PLAYER_SUCCESS_MODIFY_NICKNAME = "Modify nickname success.";

		public const string LOG_PLAYER_FAILURE_MODIFY_NICKNAME = "Failed to modify nickname.";

		public const string LOG_PLAYER_SUCCESS_MODIFY_BIRTHDATE = "Modify birth date success.";

		public const string LOG_PLAYER_FAILURE_MODIFY_BIRTHDATE = "Failed to modify birth date.";

		public const string LOG_PLAYER_SUCCESS_MODIFY_GENDER = "Modify gender success.";

		public const string LOG_PLAYER_FAILURE_MODIFY_GENDER = "Failed to modify gender.";

		public const string LOG_PLAYER_SUCCESS_MODIFY_STATUS_MSG = "Modify status msg success.";

		public const string LOG_PLAYER_FAILURE_MODIFY_STATUS_MSG = "Failed to modify status msg.";

		public const string LOG_PLAYER_SUCCESS_UPLOAD_PHOTO = "Upload photo success.";

		public const string LOG_PLAYER_FAILURE_UPLOAD_PHOTO = "Failed to upload photo.";

		public const string LOG_LEADERBOARD_SUCCESS_LOAD_LB = "Load leaderboard success.";

		public const string LOG_LEADERBOARD_FAILURE_LOAD_LB = "Failed to load leaderboard.";

		public const string LOG_LEADERBOARD_SUCCESS_LOAD_RANKING = "Load ranking success.";

		public const string LOG_LEADERBOARD_FAILURE_LOAD_RANKING = "Failed to load ranking.";

		public const string LOG_LEADERBOARD_SUCCESS_UPLOAD_SCORE = "Upload score success.";

		public const string LOG_LEADERBOARD_FAILURE_UPLOAD_SCORE = "Failed to upload score.";

		public const string LOG_LEADERBOARD_SUCCESS_LOAD_CONFIG = "Load config success.";

		public const string LOG_LEADERBOARD_FAILURE_LOAD_CONFIG = "Failed to load config.";

		public const string LOG_PROFILE_ERROR_MEMBERLIST_EMPTY = "Member list emtpy.";

		public const string LOG_PROFILE_ERROR_PHOTOURL_EMPTY = "Photo url emtpy.";

		public const string LOG_PLAYER_ERROR_INVALID_NICKNAME = "Invalid nickname.";

		public const string LOG_PLAYER_ERROR_INVALID_BIRTHDATE = "Invalid birth date.";

		public const string LOG_PLAYER_ERROR_NOT_BIRTH_NUMERIC = "Birth date is not numeric type.";

		public const string LOG_PLAYER_ERROR_INVALID_RANGE_BIRTHDATE = "Birth date range is invalid.";

		public const string LOG_PLAYER_ERROR_EMPTY_STATUS_MESSAGE = "Empty status message.";

		public const string LOG_PLAYER_ERROR_PHOTO_DATA_NULL = "Photo data null.";

		public const string LOG_LAUNCHING_ERROR_FACEBOOK_PERMISSIONS = "Check additional infomation for Facebook authentication in the HSA.";

		public const string RESULT_SUCCESS = "Success.";

		public const string RESULT_SERVER_ERROR = "Server error occurred";

		public const string RESULT_INVALID_PARAMETER = "Invalid parameter.";

		public const string RESULT_NOT_EQUAL_TRANSACTION_ID = "Transaction ID of response message is different.";

		public const string RESULT_REQUEST_TIMEOUT = "Failed to get response by request timeout.";

		public const string RESULT_NOT_SUPPORT_DOMAIN = "Not supported domain.";

		public const string RESULT_DUPLICATED_REQUEST = "Duplicated request.";

		public const string RESULT_NOT_INITIALIZED = "Not initialized.";

		public const string RESULT_NOT_REGISTERED_IN_HSA = "Not registered info in HSA.";

		public const string RESULT_SOCKET_ERROR = "Socket error occurred.";

		public const string RESULT_AUTH_FAILURE_TOAST_AUTHENTICATION = "Failed to authenticate with Toast.";

		public const string RESULT_FACEBOOK_FAILURE_LOGIN = "Failed to login with facebook.";

		public const string RESULT_FACEBOOK_FAILURE_GET_USERINFO = "Failed to get facebook user info.";

		public const string RESULT_FACEBOOK_FAILURE_CANVAS_PAY = "Failed to pay with facebook.";

		public const string RESULT_PAYMENT_INVALID_TRANSACTION_ID = "Invalid payment transaction ID.";

		public const string RESULT_PAYMENT_INVALID_PRODUCT_URL = "Invalid product URL.";

		public const string RESULT_PAYMENT_INVALID_REQUEST_ID = "Invalid request ID.";

		public const string RESULT_PLAYER_INVALID_PHOTOSERVER_URL = "Invalid photo server URL.";

		public const string RESULT_AUTH_TOAST_ACCESS_TOKEN_EMPTY = "Toast access token empty.";

		public const string RESULT_PUSH_NOTIFICATION_FAILED = "Failed to send push notification.";

		public const string RESULT_NOT_LOGIN = "Not logged in.";

		public const string ERROR_NOT_EXIST_SDK_GAMEOBJECT = "The game object for HSP Unity SDK is not exist.";

		public const string ERROR_NOT_SETTING_GAME_NO = "Please setup the Game No.";

		public const string ERROR_NOT_SETTING_GAME_ID = "Please setup the Game Id.";

		public const string ERROR_NOT_SETTING_GAME_VERSION = "Please setup the Game Version.";
	}
}
