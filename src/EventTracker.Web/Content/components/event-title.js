import { PolymerElement, html } from '@polymer/polymer';

class EventTitle extends PolymerElement {

    static get properties() {
        return {
            title: String,
            hash: String,
            date: String
        };
    }

    static get template() {
        return html`
            ${this.stylesheet}
            <h4>
                <a href="#[[hash]]-Modal" role="button" data-toggle="modal">[[title]]</a><br />
                <small>[[date]]</small>
            </h4>
        `;
    }
}

customElements.define('event-title', EventTitle);