# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

    The version of the OpenAPI document: Beta-3.0.0
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from dataclasses import dataclass
import typing_extensions
import urllib3
from pydantic import RootModel
from newscatcherapi_client.request_before_hook import request_before_hook
import json
from urllib3._collections import HTTPHeaderDict

from newscatcherapi_client.api_response import AsyncGeneratorResponse
from newscatcherapi_client import api_client, exceptions
from datetime import date, datetime  # noqa: F401
import decimal  # noqa: F401
import functools  # noqa: F401
import io  # noqa: F401
import re  # noqa: F401
import typing  # noqa: F401
import typing_extensions  # noqa: F401
import uuid  # noqa: F401

import frozendict  # noqa: F401

from newscatcherapi_client import schemas  # noqa: F401

from newscatcherapi_client.model.validation_error import ValidationError as ValidationErrorSchema
from newscatcherapi_client.model.source_response import SourceResponse as SourceResponseSchema
from newscatcherapi_client.model.source_response_sources import SourceResponseSources as SourceResponseSourcesSchema
from newscatcherapi_client.model.http_validation_error import HTTPValidationError as HTTPValidationErrorSchema
from newscatcherapi_client.model.sources_request import SourcesRequest as SourcesRequestSchema
from newscatcherapi_client.model.validation_error_loc import ValidationErrorLoc as ValidationErrorLocSchema
from newscatcherapi_client.model.user_input import UserInput as UserInputSchema

from newscatcherapi_client.type.source_response import SourceResponse
from newscatcherapi_client.type.user_input import UserInput
from newscatcherapi_client.type.validation_error_loc import ValidationErrorLoc
from newscatcherapi_client.type.validation_error import ValidationError
from newscatcherapi_client.type.sources_request import SourcesRequest
from newscatcherapi_client.type.source_response_sources import SourceResponseSources
from newscatcherapi_client.type.http_validation_error import HTTPValidationError

from ...api_client import Dictionary
from newscatcherapi_client.pydantic.source_response import SourceResponse as SourceResponsePydantic
from newscatcherapi_client.pydantic.validation_error_loc import ValidationErrorLoc as ValidationErrorLocPydantic
from newscatcherapi_client.pydantic.sources_request import SourcesRequest as SourcesRequestPydantic
from newscatcherapi_client.pydantic.http_validation_error import HTTPValidationError as HTTPValidationErrorPydantic
from newscatcherapi_client.pydantic.user_input import UserInput as UserInputPydantic
from newscatcherapi_client.pydantic.validation_error import ValidationError as ValidationErrorPydantic
from newscatcherapi_client.pydantic.source_response_sources import SourceResponseSources as SourceResponseSourcesPydantic

from . import path

# body param
SchemaForRequestBodyApplicationJson = SourcesRequestSchema


request_body_sources_request = api_client.RequestBody(
    content={
        'application/json': api_client.MediaType(
            schema=SchemaForRequestBodyApplicationJson),
    },
    required=True,
)
_auth = [
    'apiKey',
]
SchemaFor200ResponseBodyApplicationJson = SourceResponseSchema


@dataclass
class ApiResponseFor200(api_client.ApiResponse):
    body: SourceResponse


@dataclass
class ApiResponseFor200Async(api_client.AsyncApiResponse):
    body: SourceResponse


_response_for_200 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor200,
    response_cls_async=ApiResponseFor200Async,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor200ResponseBodyApplicationJson),
    },
)
SchemaFor422ResponseBodyApplicationJson = HTTPValidationErrorSchema


@dataclass
class ApiResponseFor422(api_client.ApiResponse):
    body: HTTPValidationError


@dataclass
class ApiResponseFor422Async(api_client.AsyncApiResponse):
    body: HTTPValidationError


_response_for_422 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor422,
    response_cls_async=ApiResponseFor422Async,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor422ResponseBodyApplicationJson),
    },
)
_status_code_to_response = {
    '200': _response_for_200,
    '422': _response_for_422,
}
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):

    def _post_mapped_args(
        self,
        lang: typing.Optional[str] = None,
        countries: typing.Optional[str] = None,
    ) -> api_client.MappedArgs:
        args: api_client.MappedArgs = api_client.MappedArgs()
        _body = {}
        if lang is not None:
            _body["lang"] = lang
        if countries is not None:
            _body["countries"] = countries
        args.body = _body
        return args

    async def _apost_oapg(
        self,
        body: typing.Any = None,
        skip_deserialization: bool = True,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        content_type: str = 'application/json',
        stream: bool = False,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        """
        [Post] Search For Sources Request
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        used_path = path.value
    
        _headers = HTTPHeaderDict()
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
        method = 'post'.upper()
        _headers.add('Content-Type', content_type)
    
        if body is schemas.unset:
            raise exceptions.ApiValueError(
                'The required body parameter has an invalid value of: unset. Set a valid value instead')
        _fields = None
        _body = None
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            body=body,
            auth_settings=_auth,
            headers=_headers,
        )
        serialized_data = request_body_sources_request.serialize(body, content_type)
        if 'fields' in serialized_data:
            _fields = serialized_data['fields']
        elif 'body' in serialized_data:
            _body = serialized_data['body']
    
        response = await self.api_client.async_call_api(
            resource_path=used_path,
            method=method,
            headers=_headers,
            fields=_fields,
            serialized_body=_body,
            body=body,
            auth_settings=_auth,
            timeout=timeout,
        )
    
        if stream:
            if not 200 <= response.http_response.status <= 299:
                body = (await response.http_response.content.read()).decode("utf-8")
                raise exceptions.ApiStreamingException(
                    status=response.http_response.status,
                    reason=response.http_response.reason,
                    body=body,
                )
    
            async def stream_iterator():
                """
                iterates over response.http_response.content and closes connection once iteration has finished
                """
                async for line in response.http_response.content:
                    if line == b'\r\n':
                        continue
                    yield line
                response.http_response.close()
                await response.session.close()
            return AsyncGeneratorResponse(
                content=stream_iterator(),
                headers=response.http_response.headers,
                status=response.http_response.status,
                response=response.http_response
            )
    
        response_for_status = _status_code_to_response.get(str(response.http_response.status))
        if response_for_status:
            api_response = await response_for_status.deserialize_async(
                                                    response,
                                                    self.api_client.configuration,
                                                    skip_deserialization=skip_deserialization
                                                )
        else:
            # If response data is JSON then deserialize for SDK consumer convenience
            is_json = api_client.JSONDetector._content_type_is_json(response.http_response.headers.get('Content-Type', ''))
            api_response = api_client.ApiResponseWithoutDeserializationAsync(
                body=await response.http_response.json() if is_json else await response.http_response.text(),
                response=response.http_response,
                round_trip_time=response.round_trip_time,
                status=response.http_response.status,
                headers=response.http_response.headers,
            )
    
        if not 200 <= api_response.status <= 299:
            raise exceptions.ApiException(api_response=api_response)
    
        # cleanup session / response
        response.http_response.close()
        await response.session.close()
    
        return api_response


    def _post_oapg(
        self,
        body: typing.Any = None,
        skip_deserialization: bool = True,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        content_type: str = 'application/json',
        stream: bool = False,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        """
        [Post] Search For Sources Request
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        used_path = path.value
    
        _headers = HTTPHeaderDict()
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
        method = 'post'.upper()
        _headers.add('Content-Type', content_type)
    
        if body is schemas.unset:
            raise exceptions.ApiValueError(
                'The required body parameter has an invalid value of: unset. Set a valid value instead')
        _fields = None
        _body = None
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            body=body,
            auth_settings=_auth,
            headers=_headers,
        )
        serialized_data = request_body_sources_request.serialize(body, content_type)
        if 'fields' in serialized_data:
            _fields = serialized_data['fields']
        elif 'body' in serialized_data:
            _body = serialized_data['body']
    
        response = self.api_client.call_api(
            resource_path=used_path,
            method=method,
            headers=_headers,
            fields=_fields,
            serialized_body=_body,
            body=body,
            auth_settings=_auth,
            timeout=timeout,
        )
    
        response_for_status = _status_code_to_response.get(str(response.http_response.status))
        if response_for_status:
            api_response = response_for_status.deserialize(
                                                    response,
                                                    self.api_client.configuration,
                                                    skip_deserialization=skip_deserialization
                                                )
        else:
            # If response data is JSON then deserialize for SDK consumer convenience
            is_json = api_client.JSONDetector._content_type_is_json(response.http_response.headers.get('Content-Type', ''))
            api_response = api_client.ApiResponseWithoutDeserialization(
                body=json.loads(response.http_response.data) if is_json else response.http_response.data,
                response=response.http_response,
                round_trip_time=response.round_trip_time,
                status=response.http_response.status,
                headers=response.http_response.headers,
            )
    
        if not 200 <= api_response.status <= 299:
            raise exceptions.ApiException(api_response=api_response)
    
        return api_response


class PostRaw(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    async def apost(
        self,
        lang: typing.Optional[str] = None,
        countries: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._post_mapped_args(
            lang=lang,
            countries=countries,
        )
        return await self._apost_oapg(
            body=args.body,
        )
    
    def post(
        self,
        lang: typing.Optional[str] = None,
        countries: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._post_mapped_args(
            lang=lang,
            countries=countries,
        )
        return self._post_oapg(
            body=args.body,
        )

class Post(BaseApi):

    async def apost(
        self,
        lang: typing.Optional[str] = None,
        countries: typing.Optional[str] = None,
        validate: bool = False,
    ):
        raw_response = await self.raw.apost(
            lang=lang,
            countries=countries,
        )
        if validate:
            return SourceResponsePydantic(**raw_response.body)
        return api_client.construct_model_instance(SourceResponsePydantic, raw_response.body)
    
    
    def post(
        self,
        lang: typing.Optional[str] = None,
        countries: typing.Optional[str] = None,
        validate: bool = False,
    ):
        raw_response = self.raw.post(
            lang=lang,
            countries=countries,
        )
        if validate:
            return SourceResponsePydantic(**raw_response.body)
        return api_client.construct_model_instance(SourceResponsePydantic, raw_response.body)


class ApiForpost(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    async def apost(
        self,
        lang: typing.Optional[str] = None,
        countries: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._post_mapped_args(
            lang=lang,
            countries=countries,
        )
        return await self._apost_oapg(
            body=args.body,
        )
    
    def post(
        self,
        lang: typing.Optional[str] = None,
        countries: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._post_mapped_args(
            lang=lang,
            countries=countries,
        )
        return self._post_oapg(
            body=args.body,
        )

