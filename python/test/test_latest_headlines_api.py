"""
    NewsCatcher News API V2

    NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python)   # noqa: E501

    The version of the OpenAPI document: 1.0.1
    Contact: team@newscatcherapi.com
    Generated by: https://konfigthis.com
"""


import unittest

import os
from newscatcherapi_client.apis.tags.latest_headlines_api import LatestHeadlinesApi  # noqa: E501
from newscatcherapi_client.configuration import Configuration
from newscatcherapi_client.api_client import ApiClient
from newscatcherapi_client.model.latest_headlines import LatestHeadlines


class TestLatestHeadlinesApi(unittest.TestCase):
    """LatestHeadlinesApi unit test stubs"""

    def setUp(self):
        configuration = Configuration(api_key={'api_key': os.environ["NEWSCATCHER_API_KEY"]})
        api_client = ApiClient(configuration)
        self.api = LatestHeadlinesApi(api_client)  # noqa: E501

    def tearDown(self):
        pass

    def test_get(self):
        """Test case for headlines_get

        Get Latest News Articles  # noqa: E501
        """
        response = self.api.get(query_params={"lang": "en"})
        assert response is not None, "Received null response"
        response = self.api.get(
            query_params={"not_sources": "nytimes.com,theguardian.com", "page": 1, "page_size": 50})
        assert response is not None, "Received null response"

    def test_post(self):
        """Test case for headlines_post

        Get Latest News Articles  # noqa: E501
        """
        response = self.api.post(body={"lang": "en"})
        assert response is not None, "Received null response"


if __name__ == '__main__':
    unittest.main()
