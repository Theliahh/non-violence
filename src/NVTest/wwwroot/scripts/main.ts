import {bootstrap} from 'angular2/platform/browser';
import {HomeComponent} from './home';
import {ROUTER_PROVIDERS} from 'angular2/router';

bootstrap(HomeComponent, [
    ROUTER_PROVIDERS
]);
