import { Component } from "@angular/core";
import { MessageService } from "./message.service";
import { Message } from "./message.model";
import { Router, NavigationEnd, NavigationCancel } from "@angular/router";
import "rxjs/add/operator/filter";

@Component({
    selector: "paMessages",
    templateUrl: "message.component.html",
})
export class MessageComponent {
    lastMessage: Message;

    constructor(messageService: MessageService, router: Router) {
        messageService.registerMessageHandler(m => this.lastMessage = m);
        router.events
                .filter(e => e instanceof NavigationEnd || e instanceof NavigationCancel)
                .subscribe(e => { this.lastMessage = null; });
    }
}