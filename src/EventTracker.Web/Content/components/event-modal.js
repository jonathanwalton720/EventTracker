import { PolymerElement, html } from '@polymer/polymer';

class EventModal extends PolymerElement {

    static get properties() {
        return {
            hash: String,
            title: String,
            date: String,
            isLoggedIn: Boolean
        };
    }

    static get template() {
        return html`
            <div id="[[hash]]-Modal" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">[[title]] <small class="pull-right">[[date]]</small></h4>
                        </div>
                        <div class="modal-body">
                            <pre><slot></slot></pre>
                        </div>
                        <div class="modal-footer">
		                    <span hidden$="{{!isLoggedIn}}">Have you attended this event? <button type="button" class="btn btn-primary btn-xs" role="button">Yes</button></span>
                            <span hidden$="{{isLoggedIn}}">You must be logged in to track your events.</span>
                        </div>
                    </div>
                </div>
            </div>
        `;
    }
}

customElements.define('event-modal', EventModal);