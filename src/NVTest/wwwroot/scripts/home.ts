import {Component} from 'angular2/core';
import {RouteConfig, ROUTER_DIRECTIVES, ROUTER_PROVIDERS} from 'angular2/router';

import {TestComponent} from './NVTApp';

@Component({
    selector:'NVT-app',
    template: `

<router-outlet></router-outlet>`,
    directives: [ROUTER_DIRECTIVES],
    providers: [
        ROUTER_PROVIDERS
    ]
})

@RouteConfig([
    { path: '/test', name: 'NVTApp', component: TestComponent },
    ])

export class HomeComponent { }