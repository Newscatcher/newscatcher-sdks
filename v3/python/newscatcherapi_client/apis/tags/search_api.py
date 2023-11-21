# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: Beta-3.0.0
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from newscatcherapi_client.paths.api_search.get import Get
from newscatcherapi_client.paths.api_search.post import Post
from newscatcherapi_client.apis.tags.search_api_raw import SearchApiRaw


class SearchApi(
    Get,
    Post,
):
    """NOTE:
    This class is auto generated by Konfig (https://konfigthis.com)
    """
    raw: SearchApiRaw

    def __init__(self, api_client=None):
        super().__init__(api_client)
        self.raw = SearchApiRaw(api_client)
