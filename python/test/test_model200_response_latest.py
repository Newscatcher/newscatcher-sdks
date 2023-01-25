"""
    NewsCatcher News API V2

    NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python)   # noqa: E501

    The version of the OpenAPI document: 1.0.1
    Contact: team@newscatcherapi.com
    Generated by: https://konfigthis.com
"""


import sys
import unittest

import newscatcherapi_client
from newscatcherapi_client.model.article import Article
from newscatcherapi_client.model.latest_headlines_user_input import LatestHeadlinesUserInput
from newscatcherapi_client.model.success_status import SuccessStatus
globals()['Article'] = Article
globals()['LatestHeadlinesUserInput'] = LatestHeadlinesUserInput
globals()['SuccessStatus'] = SuccessStatus
from newscatcherapi_client.model.model200_response_latest import Model200ResponseLatest


class TestModel200ResponseLatest(unittest.TestCase):
    """Model200ResponseLatest unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testModel200ResponseLatest(self):
        """Test Model200ResponseLatest"""
        # FIXME: construct object with mandatory attributes with example values
        # model = Model200ResponseLatest()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
